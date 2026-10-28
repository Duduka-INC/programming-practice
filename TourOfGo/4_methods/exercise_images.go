package main

import (
	"image"
	"image/color"

	"golang.org/x/tour/pic"
)

/*
Exercise: Images
Remember the picture generator you wrote earlier? Let's write another one, but this time it will return an implementation of image.Image instead of a slice of data.

Define your own Image type, implement the necessary methods, and call pic.ShowImage.

Bounds should return a image.Rectangle, like image.Rect(0, 0, w, h).

ColorModel should return color.RGBAModel.

At should return a color; the value v in the last picture generator corresponds to color.RGBA{v, v, 255, 255} in this one.
*/

type Image struct {
	w, h int
}

func (i Image) Bounds() image.Rectangle {
	return image.Rect(0, 0, i.w, i.h) //why not? image.Rectangle{image.Point{w, h}}

}

func (i Image) ColorModel() color.Model {
	return color.RGBAModel
}

func (i Image) At(x, y int) color.Color {
	r := mathFunction(x, y)
	g := mathFunction(x, y)
	b := mathFunction(x, y)

	return color.RGBA{r, g, b, 255}
}

func ExerciseImages() {
	m := Image{512, 512}
	pic.ShowImage(m)

	SaveImage(m, "./4_methods/picture.png")
}

func mathFunction(x, y int) uint8 {
	//result := (x ^ y)
	//result := (x + y) / 2
	result := x + y
	// result := x * y

	return uint8(result)
}
