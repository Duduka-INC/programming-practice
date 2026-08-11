package main

import (
	"fmt"
)

/*
For continued
The init and post statements are optional.
*/

func ForContinued() {
	sum := 1
	for sum < 1000 {
		sum += sum
	}
	fmt.Println(sum)
}
