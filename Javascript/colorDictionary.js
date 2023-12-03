const color = readLine()

const colorDictionary = {
  red: 1,
  green: 2,
  black: 3
}

let message

if (color in colorDictionary) {
  message = colorDictionary[color]
} else message = 'unknown'

console.log(message)
