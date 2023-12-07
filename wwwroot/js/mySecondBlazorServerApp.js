class App {
    constructor() {
        
    }

    sayHello(message = "Hello world!") {
        console.log(message);
        return message;
    }
}

globalThis.$R = {};

$R.app = new App();
$R.sections = {};