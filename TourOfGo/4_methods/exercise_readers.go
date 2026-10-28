package main

/*
Exercise: Readers
Implement a Reader type that emits an infinite stream of the ASCII character 'A'.
*/

import "golang.org/x/tour/reader"

type MyReader struct{}

// TODO: Add a Read([]byte) (int, error) method to MyReader.
func (m MyReader) Read(b []byte) (int, error) {
	for i := range b {
		b[i] = 'A'
	}

	return len(b), nil
}

func ExersiceReaders() {
	reader.Validate(MyReader{})
}
