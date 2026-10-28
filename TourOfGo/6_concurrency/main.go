package main

import "fmt"

func main() {
	// Goroutines

	/* runFunc("Goroutines", Goroutines)

	runFunc("Channels", Channels)

	runFunc("Buffered channels", BufferedChannels)

	runFunc("Range and Close", RangeAndClose)

	runFunc("Select", Select)

	runFunc("Default Selection", DefaultSelection) */

	runFunc("Exercise Equivalent Binary Trees", ExerciseEquivalentBinaryTrees)

	runFunc("sync.Mutex", SyncMutex)

	runFunc("Exercise Web Crawler", ExerciseWebCrawler)
}

func runFunc(title string, function func()) {
	fmt.Println("")
	fmt.Println(title)
	function()
}
