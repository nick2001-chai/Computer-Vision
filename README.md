# 🖼️ Computer Vision Photo Editor

A Windows Forms desktop application built with **C#** and **Emgu CV** (OpenCV wrapper for .NET) as a final project for the Computer Science faculty at the **National University of Laos**.

The application provides an interactive GUI for learning and experimenting with core computer vision techniques — from basic pixel manipulation to real-time face detection using a webcam.

---

## 📸 Features Overview

| Module | What it does |
|--------|-------------|
| 🎨 Convert to Gray | Grayscale conversion, negative, invert, log & power-law transforms |
| 📊 Histogram | Visualize R, G, B channel histograms |
| ⬛ Image Binarization | Threshold binary, Otsu, Gaussian & mean adaptive thresholding |
| 🔍 Edge Detection | Canny, Sobel, and Laplacian edge detectors |
| 🔷 Morphology | Dilation, erosion, opening, closing, gradient, top-hat, black-hat |
| 🔶 Contour | Find contours, sort by area, detect shapes (triangle, square, rectangle, hexagon) |
| 📹 VDO Processing | Live webcam stream with real-time gray/binary filter, plus video file playback |
| 👤 Face Detection | Detect faces and eyes from images using Haar cascade and LBP cascade classifiers |

---

## 🛠️ Technologies Used

- **Language:** C# (.NET Framework 4.7.2)
- **GUI:** Windows Forms
- **Computer Vision Library:** [Emgu CV](http://www.emgu.com/) (OpenCV wrapper)
- **Charting:** ZedGraph (for histogram display)
- **IDE:** Visual Studio 2019 / 2022

---

## ⚙️ Requirements

- Windows OS
- Visual Studio 2019 or later
- .NET Framework 4.7.2
- Emgu CV 3.x NuGet packages (already included in `bin/Debug`)

> The required DLLs (`cvextern.dll`, `Emgu.CV.World.dll`, `Emgu.CV.UI.dll`, `ZedGraph.dll`, etc.) are bundled in the project's `bin/Debug` folder.

---

## 🚀 Getting Started

1. **Clone or download** this repository.
2. Open `Project Computer Vision Final.sln` in Visual Studio.
3. Build the solution (`Ctrl+Shift+B`).
4. Run the project (`F5`).

> **Note:** For face detection, the cascade XML files (`haarcascade_frontalface_default.xml`, `haarcascade_eye.xml`, `lbpcascade_frontalface.xml`) are located in the `data/` folder. You may need to update the file paths inside `facedetection.cs` to match your local machine.

---

## 📁 Project Structure

```
Project Computer Vision Final/
│
├── Form1.cs                  # Main window — navigation between modules
├── ConvertToGray.cs          # Grayscale & pixel-level transformations
├── Histogram.cs              # RGB channel histogram viewer
├── ImageBinarization.cs      # Thresholding operations
├── EdgeDetection.cs          # Canny / Sobel / Laplacian edge detectors
├── Morphology.cs             # Morphological operations
├── Contour.cs                # Contour detection & shape recognition
├── VDO.cs                    # Webcam & video file processing
├── facedetection.cs          # Face & eye detection (Haar + LBP)
│
├── data/
│   ├── haarcascade_frontalface_default.xml
│   ├── haarcascade_eye.xml
│   └── lbpcascade_frontalface.xml
│
└── Resources/                # App resource images (About Us page)
```

---

## 🔬 Module Details

### 1. Convert to Gray (`ConvertToGray.cs`)

Demonstrates multiple ways to process pixel intensity, operating directly on each pixel's RGB values.

| Function | Description |
|----------|-------------|
| `ConvertToGrayScale()` | Averages R, G, B channels: `avg = (R + G + B) / 3` |
| `ConvertToGrayScale2()` | Uses the **luminance formula**: `0.3R + 0.59G + 0.11B` — more accurate to human perception |
| `Thresholding1()` | Converts to gray, then sets pixels above a threshold to white (255) and below to black (0) |
| `Negative()` | Inverts each channel: `new_value = 255 - original_value` |
| `Invert()` | Flips only pure black (0) and pure white (255) pixels |
| `logTransformation()` | Applies log scaling: `s = C × log(1 + r)` — brightens dark areas |
| `powerLaw()` | Applies gamma correction: `s = C × r^γ` — adjusts contrast based on a user-defined gamma value |

> 💡 The **luminance formula** (`ConvertToGrayScale2`) produces more natural-looking gray images because the human eye is most sensitive to green light.

---

### 2. Histogram (`Histogram.cs`)

Separates an image into its **Red**, **Green**, and **Blue** channels and plots a 256-bin histogram using the ZedGraph library. Switch between channels using radio buttons to see how each contributes to the overall image.

```
oriImage[0] → Blue channel
oriImage[1] → Green channel
oriImage[2] → Red channel
```

---

### 3. Image Binarization (`ImageBinarization.cs`)

Converts a grayscale image into a pure black-and-white (binary) image using different thresholding strategies via `CvInvoke.Threshold()`.

| Method | How it works |
|--------|-------------|
| **Binary** | Pixels > 100 → white; otherwise black |
| **Binary Invert** | Opposite of Binary |
| **Otsu** | Automatically finds the optimal threshold by analyzing the histogram |
| **Gaussian Adaptive** | Threshold is the weighted Gaussian average of the local neighborhood |
| **Mean Adaptive** | Threshold is the mean of the local neighborhood |

> 💡 Adaptive methods work well on images with uneven lighting, where a single global threshold would fail.

---

### 4. Edge Detection (`EdgeDetection.cs`)

Detects edges (sharp transitions in intensity) using three classic algorithms.

| Algorithm | How it works | Parameters |
|-----------|-------------|------------|
| **Canny** | Multi-stage: noise reduction → gradient → non-max suppression → hysteresis | Threshold 1, Threshold 2 |
| **Sobel** | Computes gradient in X and Y directions using convolution kernels | Kernel size |
| **Laplacian** | Detects edges via the second derivative of intensity | Kernel size |

Parameters can be typed into text boxes and results update live.

---

### 5. Morphology (`Morphology.cs`)

Applies shape-based transformations using a structuring element (kernel). Works on both **color** and **binary** images.

| Operation | Description |
|-----------|-------------|
| **Dilation** | Expands bright regions — fills holes, connects nearby objects |
| **Erosion** | Shrinks bright regions — removes small noise |
| **Opening** | Erosion then Dilation — removes small bright spots |
| **Closing** | Dilation then Erosion — fills small dark gaps |
| **Gradient** | Difference between dilation and erosion — highlights edges |
| **Top Hat** | Difference between original and opening — extracts small bright features |
| **Black Hat** | Difference between closing and original — extracts small dark features |

All parameters are controlled via **trackbars** that update the output in real time.

---

### 6. Contour (`Contour.cs`)

Finds and analyzes the outlines (contours) of objects in an image.

**Find Contour** — Converts the image to binary, then uses `CvInvoke.FindContours()` with `RetrType.External` and `ChainApproxSimple` to trace the outer boundaries of all objects. Results are drawn on a blank canvas.

**Sorting Contour** — Finds all contours, computes their area using `CvInvoke.ContourArea()`, sorts them in descending order, and draws **bounding rectangles** around the 3 largest objects.

**Shape Detection** — Identifies the geometric shape of each contour by approximating its polygon using `CvInvoke.ApproxPolyDP()`:

```
3 vertices  → Triangle
4 vertices  → Square (if width ≈ height) or Rectangle
6 vertices  → Hexagon
```

The shape name is written at the contour's centroid, calculated using image moments:
```
centroid_x = M10 / M00
centroid_y = M01 / M00
```

---

### 7. VDO Processing (`VDO.cs`)

Handles real-time video from either a webcam or a video file.

**Webcam mode** — Opens the default camera (`VideoCapture(0)`) and hooks into `Application.Idle` to continuously retrieve frames. Available filters:
- **Color** (default live view)
- **Gray** — converts each frame using `ToImage<Gray, byte>()`
- **Binary** — applies `ThresholdBinary` at value 150 per frame

**Video file mode** — Loads a video file via `OpenFileDialog`, reads frames using `capture.Read()`, and plays them back respecting the file's FPS:
```csharp
double fps = capture.GetCaptureProperty(CapProp.Fps);
await Task.Delay(1000 / Convert.ToInt32(fps));
```

A **capture** button saves the current frame to a second picture box, and a **save** button exports it as a JPEG.

---

### 8. Face Detection (`facedetection.cs`)

Detects human faces (and eyes) in a loaded image using pre-trained **Haar cascade** and **LBP cascade** classifiers from OpenCV.

**Haar Cascade (`DetectFaceHaar`)**
1. Converts image to grayscale.
2. Uses `haarcascade_frontalface_default.xml` to detect faces with `DetectMultiScale(scale=1.1, minNeighbors=15)`.
3. For each detected face, restricts the region of interest (ROI) and detects eyes using `haarcascade_eye.xml`.
4. Draws a **red rectangle** around faces and a **green rectangle** around eyes.

**LBP Cascade (`DetectFaceLBP`)**
1. Uses `lbpcascade_frontalface.xml` — faster but slightly less accurate than Haar.
2. Detects faces with `DetectMultiScale(scale=1.1, minNeighbors=7)`.
3. Draws a **blue rectangle** around detected faces.

| Classifier | Speed | Accuracy | Color |
|------------|-------|----------|-------|
| Haar | Slower | Higher | Red (face) / Green (eye) |
| LBP | Faster | Slightly lower | Blue |

---

## 🎬 ວິດີໂອສາທິດ (Video Demo)

> ວິດີໂອດ້ານລຸ່ມນີ້ອະທິບາຍໂຄງການນີ້ເປັນພາສາລາວ — ເໝາະສຳລັບນັກສຶກສາ ແລະ ຜູ້ໃຊ້ລາວ.
>
> *(The video below explains this project in the Lao language — suitable for Lao students and users.)*

> **📺 [▶ ເບິ່ງວິດີໂອສາທິດ / Watch Demo Video](https://drive.google.com/file/d/1TlyKRjxFdj-rfNoX3jU-jzFMX0Or_lIX/view?usp=drive_link)**

The video covers a full walkthrough of all modules in the application, including live demonstrations of:
- Image transformation techniques (grayscale, negative, log, power-law)
- Histogram channel visualization
- Binarization and thresholding methods
- Edge detection (Canny, Sobel, Laplacian)
- Morphological operations
- Contour detection and shape recognition
- Real-time webcam processing
- Face and eye detection

---

## 👥 Credits

This project was developed and presented by:

| Name | Role |
|------|------|
| **Ms Chaipasong Vongphansy** | Developer & presenter |
| **Mr Khounpaserd Hormsombat** | Co-developer & co-presenter in the demo video |

Special thanks to **Mr. Khounpaserd Hormsombat** for joining and contributing to both the project development and the video explanation. 🙏

---

## 🏫 About

This project was created as a final assignment for the **Computer Vision** course at the **Faculty of Computer Science, National University of Laos**.

It was built to demonstrate and explore foundational computer vision concepts using the Emgu CV library in a C# Windows Forms environment.

---

## 📄 License

This project is for educational purposes. Feel free to use it as a reference for learning computer vision with Emgu CV / OpenCV in C#.
