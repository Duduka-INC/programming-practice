package main

import "fmt"

func InterfaceTasks() {
	runFunc("#1", Interfaces1)

	runFunc("#2", Interfaces2)
}

/*
31. Notifier
Объяви интерфейс:
Notifier
с методом:
Notify(message string) error
Сделай две реализации:
EmailNotifier
ConsoleNotifier
И функцию:
func SendNotification(n Notifier, message string) error
Функция не должна знать конкретный тип notifier.
*/

type Notifier interface {
	Notify(message string) error
}

type EmailNotifier struct {
}

type ConsoleNotifier struct {
}

/* func (e EmailNotifier) Error() string {
	return "Fail to notify using Email"
}

func (e ConsoleNotifier) Error() string {
	return "Fail to notify using Console"
} */

func (e EmailNotifier) Notify(message string) error {
	fmt.Println("trying to send via Email")

	return nil
}

func (c ConsoleNotifier) Notify(message string) error {
	fmt.Println("trying to send via Console")

	return nil
}

func SendNotification(n Notifier, message string) error {
	return n.Notify(message)
}

func Interfaces1() {
	email := EmailNotifier{}
	console := ConsoleNotifier{}

	message := "Hello Go!"
	SendNotification(email, message)
	SendNotification(console, message)
}

/*
32. Reader
Сделай тип:
type ZeroReader struct{}
который реализует io.Reader и бесконечно выдаёт:
000000000000...
Нужно самому вспомнить правильную сигнатуру Read.
*/

type ZeroReader struct{}

func (z ZeroReader) Read(b []byte) (int, error) {
	for i := range b {
		b[i] = '0'
	}
	return len(b), nil
}

func Interfaces2() {
	z := ZeroReader{}

	b := make([]byte, 8)

	n, err := z.Read(b)

	fmt.Println(n, err)
	fmt.Printf("%q\n", b[:n])
}

/*
33. Type switch
Напиши:
func Describe(v any) string
Поведение:
int     → "integer"
string  → "string"
bool    → "boolean"
другое  → "unknown"
Используй type switch.
*/

func Describe(v any) string {
	switch v.(type) {
	case int:
		return "integer"
	case string:
		return "string"
	case bool:
		return "boolean"
	default:
		return "unknown"
	}
}
