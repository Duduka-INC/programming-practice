package main

import (
	"fmt"
)

func main() {
	// Methods
	runFunc("Methods", Methods)

	runFunc("Methods are functions", MethodsAreFunctions)

	runFunc("Methods continued", MethodsContinued)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}
