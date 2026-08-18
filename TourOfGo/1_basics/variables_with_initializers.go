package main

import (
	"fmt"
)

/*
Variables with initializers
A var declaration can include initializers, one per variable.

If an initializer is present, the type can be omitted; the variable will take the type of the initializer.
*/
func VariablesWithInitializers() {
	var i, j int = 1, 2
	var c, python, java = true, false, "no!"
	fmt.Println(i, j, c, python, java)
}
