package main

import (
	"io"
	"os"
	"strings"
)

/*
Exercise: rot13Reader
A common pattern is an io.Reader that wraps another , modifying the stream in some way. io.Reader

For example, the gzip.NewReader function takes an (a stream of compressed data) and returns a that also implements (a stream of the decompressed data). io.Reader*gzip.Readerio.Reader

Implement a that implements and reads from an , modifying the stream by applying the rot13 substitution cipher to all alphabetical characters. rot13Readerio.Readerio.Reader

The type is provided for you. Make it an by implementing its method. rot13Readerio.ReaderRead
*/

type rot13Reader struct {
	r io.Reader
}

func (r rot13Reader) Read(b []byte) (int, error) {
	n, err := r.r.Read(b)
	stream := b[:n]

	for i := range stream {
		s := b[i]

		if s <= 'Z' && s >= 'A' {
			b[i] = 'A' + (s-'A'+13)%26
		} else if s <= 'z' && s >= 'a' {
			b[i] = 'a' + (s-'a'+13)%26
		}

	}
	if err == io.EOF {
		return n, io.EOF
	}

	return n, nil

}

func ExerciseRot13Reader() {
	s := strings.NewReader("Lbh penpxrq gur pbqr!")
	r := rot13Reader{s}
	io.Copy(os.Stdout, &r)
}
