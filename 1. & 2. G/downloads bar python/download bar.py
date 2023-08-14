import time
import requests
import os
from tqdm import tqdm


# Function to format the download speed in a human-readable format
def format_speed(speed):
    if speed > 1e6:
        return "{:.2f} MB/s".format(speed / 1e6)
    elif speed > 1e3:
        return "{:.2f} kB/s".format(speed / 1e3)
    else:
        return "{:.2f} B/s".format(speed)


# Start time for the downloads
start_time = time.time()

# Check if the "downloads" folder exists in the current directory
if not os.path.exists("./downloads"):
    # Create the "downloads" folder if it does not exist
    os.mkdir("./downloads")

# Open the file containing the URLs
with open("urls.txt", "r") as f:
    # Read the URLs from the file
    urls = f.read().splitlines()

    # Iterate over the URLs and download each file
    for url in urls:
        print(f"File: {url}")
        # Send a GET request to download the file
        response = requests.get(url, stream=True)

        # Total size of the file in bytes
        total_size = int(response.headers.get("Content-Length", 0))

        # Create a progress bar for the current file being downloaded
        bar = tqdm(total=total_size, unit="B", unit_scale=True, desc=url.split("/")[-1])

        # Open a file with the same name as the URL's file name in the downloads folder
        with open(f'./downloads/{url.split("/")[-1]}', "wb") as f:
            # Iterate over the response data and update the progress bar
            for data in response.iter_content(chunk_size=4096):
                # Update the progress bar
                bar.update(len(data))
                # Write the data to the file
                f.write(data)

        # Close the progress bar
        bar.close()

        # Calculate the elapsed time and the remaining time
        elapsed = time.time() - start_time
        avg_speed = bar.n / elapsed
        remaining = (total_size - bar.n) / avg_speed
        print("Elapsed time: {:.2f} seconds".format(elapsed))
        print("Remaining time: {:.2f} \n".format(remaining))
