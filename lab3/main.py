from PIL import Image, ImageDraw, ImageFont
import math
import imageio
import matplotlib.pyplot as plt
import numpy as np

# Set up constants
width = 500
height = 125
num_circles = 30
RING_RADIUS = 50
ring_color_step = 255 // num_circles
laptop_filename = "C:/Users/Sophie/Downloads/Дизайн без назви.png"
font_file = "C:/Users/Sophie/Downloads/debrosee-font/Debrosee-ALPnL.ttf"
stars_size = 10
stars_spacing = 30
stars_frames_per_cycle = 20
num_stars = 20


def draw_star(draw, position, size, fill):
    radius = size // 2
    x, y = position
    points = []
    for i in range(5):
        angle_deg = 36 + i * 72
        angle_rad = math.pi / 180 * angle_deg
        points.append((x + radius * math.cos(angle_rad), y - radius * math.sin(angle_rad)))
        points.append((x + radius / 2 * math.cos(angle_rad + math.pi / 5), y - radius / 2 * math.sin(angle_rad + math.pi / 5)))
    draw.polygon(points, fill=fill)


def plot_frames(frames):
    # Calculate number of rows and columns for the grid
    num_images = len(frames)
    num_cols = 5
    num_rows = math.ceil(num_images / num_cols)

    # Create an empty grid to hold the images
    grid = np.zeros((num_rows * height, num_cols * width, 3), dtype=np.uint8)

    # Load each image and add it to the grid
    for i in range(num_images):
        # Load image using OpenCV
        img = frames[i]
        # Calculate row and column indices for the current image
        row = i // num_cols
        col = i % num_cols
        # Add image to the grid
        grid[row * height:(row + 1) * height, col * width:(col + 1) * width] = img

    # Display the grid of images
    plt.figure(figsize=(20, 20))
    plt.imshow(grid)
    plt.axis('off')
    plt.show()


def generate_frames():
    laptop = Image.open(laptop_filename).convert("RGBA")
    laptop = laptop.resize((int(RING_RADIUS * 2), int(RING_RADIUS * 2)), Image.ANTIALIAS)

    # Create each frame of the animation
    frames = []
    for i in range(60):
        # Create a new image
        img = Image.new('RGB', (width, height), (0, 0, 0))
        draw = ImageDraw.Draw(img)

        # Draw the text
        font = ImageFont.truetype(font_file, height // 3)
        text_width, text_height = draw.textsize('COMPUTER SCIENCE', font=font)
        x = width - text_width - 20
        y = 50 + 20 * math.sin(i / 5)
        draw.text((x, y), 'COMPUTER SCIENCE', fill=(255, 255, 255), font=font)

        # Draw the ring
        ring_radius = 60 + 10 * math.sin(i / 10)
        ring_color = (i * ring_color_step % 256, (i * ring_color_step + 85) % 256, (i * ring_color_step + 170) % 256)

        x = 10 + 50 - ring_radius
        y = (height - ring_radius * 2) / 2
        draw.ellipse((x, y, x + ring_radius * 2, y + ring_radius * 2), fill=ring_color, outline=(255, 255, 255),
                     width=4)

        # Paste the laptop image into the ring
        laptop_x = x + ring_radius - laptop.width / 2
        laptop_y = y + ring_radius - laptop.height / 2
        img.paste(laptop, (int(laptop_x), int(laptop_y)), mask=laptop.split()[3])

        # Draw the stars
        star_positions = [(i * stars_spacing + 150, height - 105) for i in range(num_stars)]
        draw = ImageDraw.Draw(img)
        for k, pos in enumerate(star_positions):
            if k % 3 == i % 3:  # check if it's time for this star to blink
                fill_color = (255, 255, 0)
            elif k % 3 == (i + 1) % 3:
                fill_color = (255, 165, 0)
            else:
                fill_color = (255, 255, 255)  # set the color to white if the star shouldn't blink
            draw_star(draw, pos, stars_size, fill_color)
        frames.append(img)
    return frames


if __name__ == "__main__":
    frames = generate_frames()
    plot_frames(frames)
    imageio.mimsave('computer_science_banner.gif', frames, fps=30)
