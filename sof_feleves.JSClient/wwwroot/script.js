document.addEventListener('DOMContentLoaded', function () {
    let connection = null;

    let servicesCount = 0;
    let guestsCount = 0;
    let hostsCount = 0;
    let totalUsers = 0;

    let totalUsersTable;

    function setupSignalR() {
        connection = new signalR.HubConnectionBuilder()
            .withUrl("https://localhost:7258/hub")
            .configureLogging(signalR.LogLevel.Information)
            .build();

        connection.on("servicecountchanged", (user, message) => {
            getData();
        });
        connection.on("useradded", (user, message) => {
            getData();
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
    }

    async function getData() {
        await fetch('https://localhost:7258/api/statistics/servicesCount')
            .then(x => x.json())
            .then(y => {
                servicesCount = y.servicesCount;
                console.log(servicesCount);
            });
        await fetch('https://localhost:7258/api/statistics/guestsCount')
            .then(x => x.json())
            .then(y => {
                guestsCount = y.guestsCount;
                console.log(guestsCount);
            });
        await fetch('https://localhost:7258/api/statistics/hostsCount')
            .then(x => x.json())
            .then(y => {
                hostsCount = y.hostsCount;
                console.log(hostsCount);
            });
        await fetch('https://localhost:7258/api/statistics/totalUsers')
            .then(x => x.json())
            .then(y => {
                totalUsers = y.totalUsers;
                console.log(totalUsers);
            });
        updateTable(getCurrentTime(), totalUsers, hostsCount, guestsCount, servicesCount);
    }


    function getCurrentTime() {
        const now = new Date();
        const hours = now.getHours().toString().padStart(2, '0');
        const minutes = now.getMinutes().toString().padStart(2, '0');
        const seconds = now.getSeconds().toString().padStart(2, '0');
        return `${hours}:${minutes}:${seconds}`;
    }


    async function updateTable(time, totalUsers, hostsCount, guestsCount, servicesCount) {
        const table = document.getElementById('data-table');
        if (!table) {
            console.error("Table element not found.");
            return;
        }


        let existingRow = findExistingRowToUpdate(table, time);

        if (!existingRow) {

            const newRow = table.insertRow(1);


            const timeCell = newRow.insertCell(0);
            const totalUsersCell = newRow.insertCell(1);
            const hostsCountCell = newRow.insertCell(2);
            const guestsCountCell = newRow.insertCell(3);
            const servicesCountCell = newRow.insertCell(4);

            timeCell.textContent = time;
            totalUsersCell.textContent = totalUsers;
            hostsCountCell.textContent = hostsCount;
            guestsCountCell.textContent = guestsCount;
            servicesCountCell.textContent = servicesCount;
        } else {
            existingRow.cells[0].textContent = time;
            existingRow.cells[1].textContent = totalUsers;
            existingRow.cells[2].textContent = hostsCount;
            existingRow.cells[3].textContent = guestsCount;
            existingRow.cells[4].textContent = servicesCount;
        }
        const maxRows = 10;
        while (table.rows.length > maxRows) {
            table.deleteRow(maxRows);
        }
    }
    function findExistingRowToUpdate(table, time) {
        for (let i = 1; i < table.rows.length; i++) {
            if (table.rows[i].cells[0].textContent === time) {
                return table.rows[i];
            }
        }
        return null; 
    }
    setupSignalR();
    getData();
});
