// SignalR Notifications
const connection = new signalR.HubConnectionBuilder()
    .withUrl('/notificationsHub') // Replace with your hub URL
    .build();

// Listen for notifications
connection.on('ReceiveNotification', (message) => {
    const li = document.createElement('li');
    li.textContent = message;
    li.className = 'list-group-item';
    document.getElementById('notificationsList').appendChild(li);
});

// Start the SignalR connection
connection.start()
    .then(() => console.log('SignalR connection established.'))
    .catch(err => console.error('Error establishing SignalR connection:', err));
