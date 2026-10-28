package main

import (
	"fmt"
)

type IPAddr [4]byte

func (i IPAddr) String() string {
	/* res := ""
	for _, value := range i {
		res += strconv.Itoa(int(value))
	}
	return fmt.Sprintf("%s", res) */

	return fmt.Sprintf("%d.%d.%d.%d", i[0], i[1], i[2], i[3])
}

func ExersiceStringers() {
	hosts := map[string]IPAddr{
		"loopback":  {127, 0, 0, 1},
		"googleDNS": {8, 8, 8, 8},
	}
	for name, ip := range hosts {
		fmt.Printf("%v: %v\n", name, ip)
	}
}
