struct Person {
    name: String,
    age: u32,
    email: String,
}

impl Person {
    fn new(name: &str, age: u32, email: &str) -> Person {
        Person {
            name: name.to_string(),
            age,
            email: email.to_string(),
        }
    }

    fn introduce(&self) -> String {
        format!("Hi, I'm {}, {} years old", self.name, self.age)
    }

    fn have_birthday(&mut self) {
        self.age += 1;
    }

    fn set_email(&mut self, email: &str) {
        if email.contains('@') {
            self.email = email.to_string();
        }
    }
}

fn main() {
    let mut person = Person::new("Alice Smith", 30, "alice@example.com");
    println!("{}", person.introduce());
    person.have_birthday();
    println!("Age after birthday: {}", person.age);
    person.set_email("alice.new@example.com");
}
