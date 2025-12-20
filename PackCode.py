import os

# Các folder muốn bỏ qua (như code bên thứ 3)
IGNORE_FOLDERS = ['Plugins', 'ThirdParty', 'TextMesh Pro']
OUTPUT_FILE = 'FullSourceCode.txt'

with open(OUTPUT_FILE, 'w', encoding='utf-8') as outfile:
    for root, dirs, files in os.walk("Assets"): # Bắt đầu quét từ Assets
        # Lọc bỏ folder không cần thiết
        dirs[:] = [d for d in dirs if d not in IGNORE_FOLDERS]

        for file in files:
            if file.endswith(".cs"): # Chỉ lấy file C#
                file_path = os.path.join(root, file)
                outfile.write(f"\n\n// ==========================================\n")
                outfile.write(f"// FILE PATH: {file_path}\n")
                outfile.write(f"// ==========================================\n\n")
                try:
                    with open(file_path, 'r', encoding='utf-8') as infile:
                        outfile.write(infile.read())
                except Exception as e:
                    outfile.write(f"// Error reading file: {e}")

print(f"Xong! Hãy upload file {OUTPUT_FILE} cho AI.")