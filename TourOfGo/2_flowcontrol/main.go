package main

import (
	"fmt"
)

func main() {
	runFunc("For", For)

	runFunc("For continued", ForContinued)

	runFunc("ForIsWhile", ForIsWhile)

	//runFunc("Forever", Forever) - infinity loop

	runFunc("If", If)

	runFunc("If with a short statement", IfWithShortStatement)

	runFunc("If and else", IfAndElse)

	runFunc("Exercise: Loops and Functions", LoopAndFunctions)

	fmt.Println(sqrt(8), sqrt(9))

	runFunc("Switch", Switch)

	runFunc("Switch evaluation order", SwitchEvaluationOrder)

	runFunc("Switch with no condition", SwitchWithNoCondition)

	runFunc("Defer", Defer)

	runFunc("Stacking defers", StackingDefer)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}
