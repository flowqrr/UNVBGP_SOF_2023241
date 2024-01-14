document.addEventListener('DOMContentLoaded', function () {
    // Initialize SignalR connection and other variables
    let connection = null;

    let servicesCount = 0;
    let guestsCount = 0;
    let hostsCount = 0;
    let totalUsers = 0;

    // SignalR table variable
    let totalUsersTable;

    // Function to set up SignalR connection
    function setupSignalR() {
        connection = new signalR.HubConnectionBuilder()
            .withUrl("https://localhost:7258/hub")
            .configureLogging(signalR.LogLevel.Information)
            .build();

        connection.on("servicecreated", (user, message) => {
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

    // Function to start the SignalR connection
    async function start() {
        try {
            await connection.start();
            console.log("SignalR Connected.");
        } catch (err) {
            console.log(err);
            setTimeout(start, 5000);
        }
    }

    // Function to fetch user data
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

    // Function to get current time
    function getCurrentTime() {
        const now = new Date();
        const hours = now.getHours().toString().padStart(2, '0');
        const minutes = now.getMinutes().toString().padStart(2, '0');
        const seconds = now.getSeconds().toString().padStart(2, '0');
        return `${hours}:${minutes}:${seconds}`;
    }

    // Function to update the HTML table
    async function updateTable(time, totalUsers, hostsCount, guestsCount, servicesCount) {
        const table = document.getElementById('data-table');
        if (!table) {
            console.error("Table element not found.");
            return;
        }

        // Check if there's an existing row to update (e.g., based on a unique identifier)
        let existingRow = findExistingRowToUpdate(table, time);

        if (!existingRow) {
            // If no existing row found, insert a new row
            const newRow = table.insertRow(1); // Insert as the second row (index 1)

            // Create table cells for each data point
            const timeCell = newRow.insertCell(0);
            const totalUsersCell = newRow.insertCell(1);
            const hostsCountCell = newRow.insertCell(2);
            const guestsCountCell = newRow.insertCell(3);
            const servicesCountCell = newRow.insertCell(4);

            // Set the data in each cell
            timeCell.textContent = time;
            totalUsersCell.textContent = totalUsers;
            hostsCountCell.textContent = hostsCount;
            guestsCountCell.textContent = guestsCount;
            servicesCountCell.textContent = servicesCount;
        } else {
            // If an existing row is found, update its cell values
            existingRow.cells[0].textContent = time;
            existingRow.cells[1].textContent = totalUsers;
            existingRow.cells[2].textContent = hostsCount;
            existingRow.cells[3].textContent = guestsCount;
            existingRow.cells[4].textContent = servicesCount;
        }

        // Limit the number of rows displayed (e.g., keep the last 10 rows)
        const maxRows = 10;
        while (table.rows.length > maxRows) {
            table.deleteRow(maxRows);
        }
    }

    // Function to find an existing row based on a unique identifier (e.g., time)
    function findExistingRowToUpdate(table, time) {
        for (let i = 1; i < table.rows.length; i++) {
            if (table.rows[i].cells[0].textContent === time) {
                return table.rows[i];
            }
        }
        return null; // No existing row found
    }

    // SignalR code
    setupSignalR();
    getData();
});
