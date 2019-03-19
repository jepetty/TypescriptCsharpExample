console.log('this is a super simple sample typescript file');

const myThing = 'hey this is bomb';

console.log(myThing);

class jessClass {
    myString: number = 5;
    myMy: string = "how can i forget you?!";
    
    constructor() {
        this.myPrivateString = 'shhh it\s a secret';
    }

    public printPrivateString() {
        console.log(this.myPrivateString);
    }

    private myPrivateString: string;
}

const myClass = new jessClass();
myClass.printPrivateString();