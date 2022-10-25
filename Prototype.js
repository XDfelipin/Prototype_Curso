const person1 = {
    name: 'Adson',
    age: 17,
}; 

const person2 = Object.create(person1);

console.log(person1.name); //Adson
console.log(person2.name); //Adson

//person1 é o prototype de person2
console.log(person1 === Object.getPrototypeOf(person2));