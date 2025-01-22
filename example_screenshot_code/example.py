class Person:
    def __init__(self, name: str, age: int, email: str):
        self.name = name
        self.age = age
        self.email = email

    def introduce(self) -> str:
        return f"Hi, I'm {self.name}, {self.age} years old"

    def have_birthday(self) -> None:
        self.age += 1

    @property
    def name(self) -> str:
        return self._name

    @name.setter
    def name(self, value: str) -> None:
        self._name = value

    def set_email(self, email: str) -> None:
        if '@' in email:
            self.email = email

if __name__ == "__main__":
    person = Person("Alice Smith", 30, "alice@example.com")
    print(person.introduce())
    person.have_birthday()
    print(person.name)
    person.set_email("alice.new@example.com")
