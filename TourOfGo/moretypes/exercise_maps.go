package main

import (
	"strings"

	"golang.org/x/tour/wc"
)

/*
Exercise: Maps
Implement WordCount. It should return a map of the counts of each “word” in the string s. The wc.Test function runs a test suite against the provided function and prints success or failure.

You might find strings.Fields helpful.
*/

func WordCount(s string) map[string]int {
	var result = map[string]int{}

	words := strings.Fields(s)
	// Difference between Fields and Split, what is Fields() split string automatically using all spaces like " ", "  ", "\n" etc.
	// Split needs character wich will be used as separator

	for _, w := range words {
		result[w]++
		/* _, ok := result[w]

		if !ok {
			result[w] = 1
		} else {
			result[w] ++
		} */
	}

	return result
}

func ExerciseMaps() {
	wc.Test(WordCount)
}
