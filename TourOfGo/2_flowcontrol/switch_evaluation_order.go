package main

import (
	"fmt"
	"time"
)

/*
Switch evaluation order
Switch cases evaluate cases from top to bottom, stopping when a case succeeds.

(For example,
switch i {
case 0:
case f():
}
does not call f if i==0.)
*/

func SwitchEvaluationOrder() {
	fmt.Println("When's Saturday?")
	today := time.Now().Weekday()
	switch time.Saturday {
	case today + 0:
		fmt.Println("Today.")
	case today + 1:
		fmt.Println("Tomorrow.")
	case today + 2:
		fmt.Println("In two days.")
	default:
		fmt.Println("Too far away.")
	}
}
