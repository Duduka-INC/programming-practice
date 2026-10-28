package main

import (
	"fmt"
	"image"
	"image/png"
	"os"
)

func main() {
	// Methods
	runFunc("Methods", Methods)

	runFunc("Methods are functions", MethodsAreFunctions)

	runFunc("Methods continued", MethodsContinued)

	runFunc("Pointer receivers", PointerReceivers)

	runFunc("Pointers and functions", PointersAndFunctions)

	runFunc("Methods and pointer indirection", MethodsAndPointerIndirection)

	runFunc("Methods and pointer indirection 2", MethodsAndPointerIndirection2)

	runFunc("Choosing a value or pointer receiver", ChoosingValueOrPointerReceiver)

	// Interfaces
	runFunc("Interfaces", Interfaces)

	runFunc("Interfaces are implemented implicitly", InterfacesAreImplementedImplicitly)

	runFunc("Interface values", InterfaceValues)

	runFunc("Interface values with nil underlying values", InterfaceValuesWithNilUnderlyingValues)

	// panic: runtime error: invalid memory address or nil pointer dereference
	// [signal 0xc0000005 code=0x0 addr=0x0 pc=0x7ff75d946a39]
	runFunc("Nil interface values", NilInterfaceValues)

	runFunc("The empty interface", EmptyInterface)

	runFunc("Type assertions", TypeAssertions)

	runFunc("Type switches", TypeSwitches)

	runFunc("Stringers", Stringers)

	runFunc("Exersice Stringers", ExersiceStringers)

	runFunc("Errors", Errors)

	runFunc("Exersice Errors", ExersiceErrors)

	runFunc("Readers", Readers)

	runFunc("Exersice Readers", ExersiceReaders)

	runFunc("Exercise rot13Reader", ExerciseRot13Reader)

	runFunc("Images", Images)

	runFunc("Exercise Images", ExerciseImages)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}

func SaveImage(img image.Image, filename string) error {
	file, err := os.Create(filename)
	if err != nil {
		return err
	}
	defer file.Close()

	return png.Encode(file, img)
}
