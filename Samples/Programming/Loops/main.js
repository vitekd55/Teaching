// function to generate list of items with for loop
function generate() {
  const list = document.getElementById("sample") // saving element with id sample to constatnt variable
  list.innerHTML = "" // cleaning the list
  const count = document.getElementById("count").value // getting value of number input
  for (let i = 1; i <= count; i++) {
    list.innerHTML += `<li>item ${i} </li>` // adding item to list | using `` insted of quotes allows you to add variables into the string
    // variable must be  prefixed with $ and surrounded with {}
  }
}
