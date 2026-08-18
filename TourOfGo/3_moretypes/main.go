package main

import (
	"fmt"
)

func main() {
	//Structs
	runFunc("Pointers", Pointers)

	runFunc("Structs", Structs)

	runFunc("Pointers to structs", PointersToStructs)

	runFunc("StructLiterals", StructLiterals)

	// Arrays
	runFunc("Arrays", Arrays)

	runFunc("Slices", Slices)

	runFunc("Slices are like references to arrays", SlicesLikeReferencesToArrays)

	runFunc("Slice literals", SliceLiterals)

	runFunc("Slice Defaults", SliceDefaults)

	runFunc("Slice length and capacity", SliceLengthAndCapacity)

	runFunc("Nil slices", NilSlices)

	runFunc("Creating slice with make", CreatingSliceWithMake)

	runFunc("Slice of slices", SliceOfSlices)

	runFunc("Appending to a slice", AppendingToSlice)

	runFunc("Range", Range)

	runFunc("Range continued", RangeContinued)

	runFunc("Exersice slices", ExersiceSlices)

	// Maps
	runFunc("Maps", Maps)

	runFunc("Map literals", MapLiterals)

	runFunc("Map literals continued", MapLiteralsContinued)

	runFunc("Mutating maps", MutatingMaps)

	runFunc("Exercise maps", ExerciseMaps)

	// Functions
	runFunc("Function values", FunctionValues)

	runFunc("Function closures", FunctionClosures)

	runFunc("Exercise Fibonacci closure", ExerciseFibonacciClosure)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}

type FuncExecutor struct {
	FuncName string
	Function func()
}

func runFuncNew(functions []FuncExecutor) {

	for _, f := range functions {
		fmt.Println("")
		fmt.Println(f.FuncName)
		f.Function()
	}
}

/* runFuncNew(
	[]FuncExecutor{
		FuncExecutor{},
	},
) */
