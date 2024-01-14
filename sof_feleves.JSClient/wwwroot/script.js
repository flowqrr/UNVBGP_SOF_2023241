let users = 0;
let connection = null;
setupSignalR();

function setupSignalR() {
    connection = new signalR.HubConnectionBuilder()
        .withUrl("https://localhost:7258/hub")
        .configureLogging(signalR.LogLevel.Information)
        .build();

    connection.on("servicecreated", (user, message) => {
        getServiceData();
    });
    connection.on("useradded", (user, message) => {
        getUserData();
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
async function getServiceData() {
    await fetch('https://localhost:7258/api/statistics/servicesCount')
        .then(x => x.json())
        .then(y => {
            actors = y;
            console.log(actors);
            //display();
        });
}

async function getUserData() {
    await fetch('https://localhost:7258/api/statistics/guestsCount')
        .then(x => x.json())
        .then(y => {
            actors = y;
            console.log(actors);
            //display();
        });
    await fetch('https://localhost:7258/api/statistics/hostsCount')
        .then(x => x.json())
        .then(y => {
            actors = y;
            console.log(actors);
            //display();
        });
    await fetch('https://localhost:7258/api/statistics/totalUsers')
        .then(x => x.json())
        .then(y => {
            actors = y;
            console.log(actors);
            //display();
        });
}
