import os
import webbrowser

with open('file_paths.txt') as f:
    for file_path_or_url in f:
        file_path_or_url = file_path_or_url.strip().replace('\\', r'\\')
        (webbrowser.open if file_path_or_url.startswith('http') else os.startfile)(file_path_or_url)