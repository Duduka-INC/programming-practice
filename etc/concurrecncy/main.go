package main

import (
	"fmt"
	"time"
)

func main() { //G0
	ch := make(chan int)

	go func() {
		fmt.Println(<-ch)
	}()

	go func() {
		ch <- 35
	}()

	time.Sleep(5 * time.Second)

}
