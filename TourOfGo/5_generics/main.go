package main

import "fmt"

func main() {
	// Generics
	runFunc("Type parameters", TypeParameters)

	runFunc("Generic types", GenericTypes)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}
