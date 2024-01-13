let users = 0;
let connection = null;
getdata();
setupSignalR();

function setupSignalR() {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("https://localhost:7258/api")
        .configureLogging(signalR.LogLevel.Information)
        .build();

    connection.on("servicescount", (user, message) => {
        getdata();
    });

    connection.onclose(async () => {
        await start();
    });
    start();
}

async function start() {
    try {
        await connection.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

async function getdata() {
    await fetch('https://localhost:7258/api/statistics/servicescount')
        .then(x => x.json())
        .then(y => {
            actors = y;
            console.log(actors);
            //display();
        });
}