export class MyList {
    constructor() {

    }

    sayHello() {
        $R.app.sayHello("MyList say hello!");
    }
}

export function sayHello() {
    $R.app.sayHello("MyList say hello standalone!");
}

export const instance = new MyList();