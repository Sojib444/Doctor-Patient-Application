let onlineConnection = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/onlineuser")
    .withAutomaticReconnect()
    .build();


onlineConnection.start();