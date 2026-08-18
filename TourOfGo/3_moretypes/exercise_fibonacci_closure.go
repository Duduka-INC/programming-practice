package main

import (
	"fmt"
)

/*
Exercise: Fibonacci closure
Let's have some fun with functions.

Implement a function that returns a function (a closure) that returns successive fibonacci numbers (0, 1, 1, 2, 3, 5, ...). fibonacci
*/

// fibonacci is a function that returns
// a function that returns an int.
func fibonacci() func() int {
	prev := 0
	curr := 1
	return func() int {
		tmp_curr := curr
		curr = prev + curr
		prev = tmp_curr

		return curr
	}
}

func ExerciseFibonacciClosure() {
	f := fibonacci()
	for i := 0; i < 10; i++ {
		fmt.Println(f())
	}
}
