package main

import (
	"cmp"
	"fmt"
)

func GenericTasks() {
	runFunc("#1", Generics1)

	runFunc("#2", Generics2)

	runFunc("#3", Generics3)

	runFunc("#4", Generics4)
}

/*
Задача 1. Contains
Напиши:
func Contains[T ???](items []T, target T) bool
Чтобы работало:
Contains([]int{1, 2, 3}, 2)       // true
Contains([]string{"a", "b"}, "c") // false
Сам выбери constraint.
*/
func Generics1() {
	fmt.Println(Contains([]int{1, 2, 3}, 2))       // true
	fmt.Println(Contains([]string{"a", "b"}, "c")) // false
}

func Contains[T comparable](items []T, target T) bool {
	for i := range items {
		if items[i] == target {
			return true
		}
	}

	return false
}

/*
Задача 2. Generic Min
func Min[T ???](a, b T) T
Должно работать с:
int
float64
string
Желательно использовать готовый constraint из стандартной библиотеки.
*/
func Generics2() {
	fmt.Println(Min(int(7), int(12)))
	fmt.Println(Min(float64(7), float64(12)))
	fmt.Println(Min("7", "12"))
	fmt.Println(Min(7, 12.6))
}

func Min[T cmp.Ordered](a, b T) T {
	if a >= b {
		return b
	} else {
		return a
	}
}

/*
Задача 3. Свой тип
type UserID int
Сделай:
func Double[T ???](v T) T
Чтобы работало:
Double(10)
Double(UserID(10))
Тут проверяем, помнишь ли ты ~.
*/
func Generics3() {
	fmt.Println(Double(10))
	fmt.Println(Double(UserID(12)))
}

type UserID int

func Double[T ~int](v T) T {
	return v * 2
}

/*
Задача 4. Generic Stack
Реализуй:

	type Stack[T any] struct {
		// ...
	}

func (s *Stack[T]) Push(v T)
func (s *Stack[T]) Pop() (T, bool)
Пример:
s := Stack[int]{}

s.Push(10)
s.Push(20)

v, ok := s.Pop() // 20, true
v, ok = s.Pop()  // 10, true
v, ok = s.Pop()  // zero value, false
Здесь самое интересное — как вернуть zero value для неизвестного T.
*/
func Generics4() {
	myStack := Stack[string]{}
	myStack.Push("pipipopi")
	fmt.Println(myStack.Pop())
	fmt.Println(myStack.Pop())
}

type Stack[T any] struct {
	storage []T
}

func (s *Stack[T]) Push(v T) {
	s.storage = append(s.storage, v)
}

func (s *Stack[T]) Pop() (T, bool) {
	if len(s.storage) == 0 {
		var empty T
		return empty, false
	}

	element := s.storage[len(s.storage)-1]
	s.storage = s.storage[:len(s.storage)-1]
	return element, true
}
