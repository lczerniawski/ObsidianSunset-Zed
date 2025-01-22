class Person {
  constructor(
    private name: string,
    private age: number,
    private email: string,
  ) {}

  public introduce(): string {
    return `Hi, I'm ${this.name}, ${this.age} years old`;
  }

  public haveBirthday(): void {
    this.age++;
  }

  // Getters and setters
  public getName(): string {
    return this.name;
  }

  public setEmail(email: string): void {
    if (email.includes("@")) {
      this.email = email;
    }
  }
}

const person = new Person("Alice Smith", 30, "alice@example.com");
console.log(person.introduce());
person.haveBirthday();
console.log(person.getName());
person.setEmail("alice.new@example.com");
