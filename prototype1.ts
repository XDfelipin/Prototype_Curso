export interface Prototype {
    clone(): Prototype
}

export	class Person implements Prototype{
    constructor(public name: string, public age:number) {}

    clone(): this {
        const newObj = Object.create(this);
        return newObj;
    }
}

const person1 = new Person('Adson', 17);
const person2 = person1.clone();

console.log(person2);
console.log(person2.name);