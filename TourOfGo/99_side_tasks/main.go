package main

import "fmt"

func main() {

	runFunc("Pointer tasks", PointerTasks)

	runFunc("Interface tasks", InterfaceTasks)

	runFunc("Generic tasks", GenericTasks)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}
