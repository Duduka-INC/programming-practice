package main

import (
	"golang.org/x/tour/pic"
)

/*
Exercise: Slices
Implement . It should return a slice of length , each element of which is a slice of 8-bit unsigned integers. When you run the program, it will display your picture, interpreting the integers as grayscale (well, bluescale) values. Picdydx

The choice of image is up to you. Interesting functions include , , and . (x+y)/2x*yx^y

(You need to use a loop to allocate each inside the .) []uint8[][]uint8

(Use to convert between types.) uint8(intValue)
*/

func Pic(dx, dy int) [][]uint8 {
	var result = [][]uint8{}

	for x := 0; x < dx; x++ {
		var line = make([]uint8, dy)
		for y := 0; y < dy; y++ {
			line[y] = uint8(mathFunction(x, y))
		}
		result = append(result, line)
	}

	return result
}

func mathFunction(x, y int) int {
	return x ^ y
	// return (x + y) / 2
	// return x + y
	// return x * y
}

func ExersiceSlices() {
	pic.Show(Pic)
}
