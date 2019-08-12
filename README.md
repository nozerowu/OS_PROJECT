# Single image haze removal
### Mingjue Wang

The propose of this repository is to implement the image haze removal base on the Kaiming HE. [paper](http://projectsweb.cs.washington.edu/research/insects/CVPR2009/award/hazeremv_drkchnl.pdf).

## Usage

The code can be executed via .exe


---


## Summary from the article.
This dehaze algorithm contains three steps,

1) Determine intensity of atmospheric light
2) Estimate transmission map
3) Clarify image

First, the intensity of atmospheric light `A` is estimated form hazed image `I(x)`. Then, the transmission map `t(x)` is estimated using `A` and `I(x)`. Finally, the image is clarified with the image defogging model.

#### Step#1 Estimate intensity of atmospheric light:
Find the top 0.1% brightest pixels in the dark channel then choose one with highest intensity as the representing of atmospheric light.

#### Step#2 Estimate transmission map:
First, find a dark channel based on a local area(coarsemap)
Then, the transmission map `t(x)` is thereby obtained:

```t(x) = 1 – defoggingParam * darkPixelFromCoarseMap / AtmosphericLightIntensity```

The ```defoggingParam``` is a value between 0 to 1. The higher value the lesser amount of fog would be kept for the distant objects.

#### Step#3 Clarify image:
Finally, the image is clarified by: ```J(x)=(I(x)- A)/max(t(x), t0)+A```

Where `J(x)` is output, `I(x)` is input, `t(x)` is transmission map, `A` is atmospheric light and `t0` is set to a constant value to avoid dividing by zero.

---

### You need to have the Visual Studio to build the exe:
After you have the exe you can run it like the normal Microsoft Applications

---

### Sample of the exe

---

### License Information
MIT License

Copyright (c) 2019 mingjue

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
