package main

import (
	"bufio"
	"fmt"
	"os"
	"sort"
	"strconv"
	"strings"
)

func stringToInt(str string) (int, error) {
	nonFractionalPart := strings.Split(str, ".")
	return strconv.Atoi(nonFractionalPart[0])
}

// readLines reads a whole file into memory
// and returns a slice of its lines.
func readLines(path string) ([]int, error) {
	file, err := os.Open(path)
	if err != nil {
		return nil, err
	}
	defer file.Close()

	var lines []int
	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		number, _ := stringToInt(scanner.Text())
		lines = append(lines, number)
	}
	return lines, scanner.Err()
}

func isCorrect(number int, size int, preamble []int) (int, int, error) {
	start := len(preamble) - size
	for i, pre1 := range preamble[start:] {
		for j, pre2 := range preamble[start:] {
			if i != j && pre1+pre2 == number {
				return i, j, nil
			}
		}
	}
	return -1, -1, fmt.Errorf("Not correct %d", number)
}

// Part2

func findStream(objective int, numbers []int) ([]int, error) {
	result := make([]int, 0)
	sum := 0

	for _, value := range numbers {
		result = append(result, value)
		sum = sum + value

		for sum > objective {
			sum = sum - result[0]
			if len(result) < 2 {
				result = make([]int, 0)
			} else {
				result = result[1:]
			}
		}

		if sum == objective {
			if len(result) > 2 {
				return result, nil
			}
			result = make([]int, 0)

		}
	}

	return nil, fmt.Errorf("Not found")
}

func findIncorrect(numbers []int, windowSize int) (int, int) {

	solucio1 := 0

	// Part 1
	for index, number := range numbers[windowSize:] {
		preamble := numbers[index : windowSize+index]
		_, _, err := isCorrect(number, windowSize, preamble)
		if err != nil {
			solucio1 = number
			break
		}
	}

	// Part 2
	consecutive, err := findStream(solucio1, numbers)
	if err != nil {
		fmt.Println(err.Error())
		return solucio1, -1
	}

	sort.Ints(consecutive)

	return solucio1, consecutive[0] + consecutive[len(consecutive)-1]
}

func main() {
	sizePreamble := 25
	filename := fmt.Sprintf("input%d", sizePreamble)
	linies, err := readLines(filename)
	if err != nil {
		panic("File read failed")
	}

	correctes1, correctes2 := findIncorrect(linies, sizePreamble)

	fmt.Println("Part 1: ", correctes1)
	fmt.Println("Part 2: ", correctes2)
}
