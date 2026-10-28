package main

import "fmt"

func PointerTasks() {
	runFunc("#1", Pointers1)

	runFunc("#2", Pointers2)

	runFunc("#3", Pointers3)

	runFunc("#4", Pointers4)

	runFunc("#5", Pointers5)

	runFunc("#6", Pointers6)

	runFunc("#7", Pointers7)

	runFunc("#8", Pointers8)

	runFunc("Bonus", BonusPointers)
}

func Pointers1() {
	x := 10 // значение переменной в x
	p := &x // p содержит адрес x

	*p = 20 // Получаем значение по ссылке *p - это x и меняем его. НЕ копию.

	fmt.Println(x)  // 20
	fmt.Println(*p) // 20
}

func Pointers2() {
	x := 10 // 10
	p := &x // p содержит указатель на x, 10

	y := *p // y получил значение p, 10
	y = 30  // y поменял значение на 30

	fmt.Println(x)  // 10
	fmt.Println(y)  // 30
	fmt.Println(*p) // 10
}

func change1(x int) {
	x = 100 // передаем копию значения и внутри функции меняем его на 100
}

func Pointers3() {
	x := 10    // 10
	change1(x) // передали копию, сам x не поменялся

	fmt.Println(x) // 10
}

func change2(x *int) {
	*x = 100 // передаем указатель и меняем значение по адресу
}

func Pointers4() {
	x := 10     // 10
	change2(&x) // передаем указатель на x

	fmt.Println(x) // 100
}

func change3(p *int) {
	x := 100 // присваиваем локульному x 100
	p = &x   // меняем указатель в p со старого x на новый x
}

func Pointers5() {
	x := 10 // 10
	p := &x // указатель на x

	change3(p) // p 100 // upd на самом деле передали копию указателя.

	fmt.Println(x)  // 10
	fmt.Println(*p) // 100 // 10
}

type User struct {
	Name string
	Age  int
}

func change4(u User) {
	u.Age = 30 // меняем значение на Age на 30
}

func Pointers6() {
	u := User{"Dima", 20} // объект
	change4(u)            // передаем копию

	fmt.Println(u.Age) // 20
}

func change5(u *User) {
	u.Age = 30 // меняем значение на 30
}

func Pointers7() {
	u := User{"Dima", 20} // объект создаем
	change5(&u)           // передаем указатель на u

	fmt.Println(u.Age) // 30
}

type Counter struct {
	Value int
}

func Increment(c *Counter) {
	c.Value++
}

func Pointers8() {
	c := Counter{Value: 10}
	Increment(&c)
	fmt.Println(c.Value) // 11
}

func BonusPointers() {
	a := 10 // 10
	b := 20 // 20

	p := &a // указатель на a
	q := p  // копия указателя на a

	*p = 30 // значение p, то есть то, что лежит в a = 30
	q = &b  // указатель на b, 20
	*q = 40 // значячение q, то есть то, что лежит в b = 40

	fmt.Println(a)  // 30
	fmt.Println(b)  // 40
	fmt.Println(*p) // 30
	fmt.Println(*q) // 40
}
