package main

import "fmt"

/*
Structs
A struct is a collection of fields.
*/

/*
Struct Fields
Struct fields are accessed using a dot.
*/

func Structs() {
	type Vertex struct {
		X    int
		Y    int
		Z    int
		Name string
	}

	obj := Vertex{1, 2, 3, "John"}
	fmt.Println(obj, obj.Name)

	obj2 := Vertex{
		X:    -1,
		Name: "pipipopi",
	}

	fmt.Println(obj2)
}

/*
Pointers to structs
Struct fields can be accessed through a struct pointer.

To access the field X of a struct when we have the struct pointer p we could write (*p).X.
However, that notation is cumbersome, so the language permits us instead to write just p.X, without the explicit dereference.
*/
func PointersToStructs() {
	type Vertex struct {
		X int
		Y int
	}

	v := Vertex{1, 2}
	p := &v
	p.X = 1e9
	fmt.Println(v)
}

/*
Struct Literals
A struct literal denotes a newly allocated struct value by listing the values of its fields.

You can list just a subset of fields by using the Name: syntax. (And the order of named fields is irrelevant.)

The special prefix & returns a pointer to the struct value.
*/

func StructLiterals() {
	type Vertex struct {
		X, Y int
	}

	var (
		v1 = Vertex{1, 2}  // has type Vertex
		v2 = Vertex{X: 1}  // Y:0 is implicit
		v3 = Vertex{}      // X:0 and Y:0
		p  = &Vertex{1, 2} // has type *Vertex
	)

	fmt.Println(v1, v2, v3, p, &p, *p)
}
