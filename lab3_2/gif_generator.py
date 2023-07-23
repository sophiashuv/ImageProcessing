from PIL import Image, ImageDraw, ImageFont
import math
import imageio
import matplotlib.pyplot as plt
import numpy as np

# Set up constants
width = 500
height = 125
num_frames = 60
fps = 30

# Load the computer image
computer_image = Image.open("computer.png")
computer_image = computer_image.resize((50, 50))
font_file = r"../Freedom-10eM.ttf"


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
    # Generate frames
    frames = []
    for i in range(num_frames):
        # Create a new image
        img = Image.new('RGB', (width, height), (53, 53, 53))
        draw = ImageDraw.Draw(img)

        # Draw the text
        font = ImageFont.truetype(font_file, 30)
        text_width, text_height = draw.textsize('STUDY COMPUTER SCIENCES', font=font)
        x = (width - text_width) / 2
        y = height / 2 - text_height - 30
        if i < num_frames//2:
            r = int(255 * i / (num_frames//2))
            g = int(255 * i / (num_frames//2))
            b = 255
        else:
            r = int(255 - 255 * (i - num_frames//2) / (num_frames//2))
            g = int(255 - 255 * (i - num_frames//2) / (num_frames//2))
            b = 255
        draw.text((x, y), 'STUDY COMPUTER SCIENCES', fill=(r, g, b), font=font)

        # Draw sinusoids
        sin_width = 2 * math.pi / width
        sin_height = 20
        sin_freq = 3
        sin_phase = i / 10
        space_between_computers = 30  # Add some space between the computer images
        for x in range(width):
            y1 = sin_height * math.sin(sin_width * sin_freq * x + sin_phase) + 25
            y2 = sin_height * math.sin(sin_width * sin_freq * x + sin_phase) + height - 25

            if x % space_between_computers == space_between_computers // 2:
                img.paste(computer_image, (x-30, int(y2-40)), mask=computer_image.split()[3])

        # Append frame to the list of frames
        frames.append(img)
    return frames


if __name__ == "__main__":
    frames = generate_frames()
    plot_frames(frames)
    # Save frames as gif
    imageio.mimsave('study_computer_science_banner.gif', frames, fps=fps)


