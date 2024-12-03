import React, { useState, useEffect } from "react";
import * as signalR from "@microsoft/signalr";

const Chat = () => {
  const [connection, setConnection] = useState(null);
  const [messages, setMessages] = useState([]);
  const [user, setUser] = useState("");
  const [message, setMessage] = useState("");

  useEffect(() => {
    const newConnection = new signalR.HubConnectionBuilder()
      .withUrl("http://localhost:5162/chatHub", {
        withCredentials: true, // Ensure credentials are sent with the request
      })
      .withAutomaticReconnect()
      .build();

    newConnection
      .start()
      .then(() => {
        console.log("Connected to SignalR hub.");

        newConnection.on("ReceiveMessage", (user, message) => {
          setMessages((prevMessages) => [...prevMessages, { user, message }]);
        });
      })
      .catch((err) => console.error("SignalR connection error: ", err));

    setConnection(newConnection);

    return () => {
      if (newConnection) newConnection.stop();
    };
  }, []);

  const sendMessage = async () => {
    if (connection && user && message) {
      try {
        await connection.invoke("SendMessage", user, message);
        setMessage("");
      } catch (err) {
        console.error("Error sending message: ", err);
      }
    }
  };

  return (
    <div style={{ padding: "20px" }}>
      <h2>SignalR ChatBot</h2>
      <div
        style={{
          border: "1px solid #ccc",
          padding: "10px",
          marginBottom: "10px",
          maxHeight: "300px",
          overflowY: "auto",
        }}
      >
        {messages.map((msg, index) => (
          <div key={index} style={{ marginBottom: "5px" }}>
            <strong>{msg.user}:</strong> {msg.message}
          </div>
        ))}
      </div>
      <div style={{ marginBottom: "10px" }}>
        <input
          type="text"
          placeholder="Your name"
          value={user}
          onChange={(e) => setUser(e.target.value)}
          style={{ marginRight: "10px" }}
        />
        <input
          type="text"
          placeholder="Your message"
          value={message}
          onChange={(e) => setMessage(e.target.value)}
          style={{ marginRight: "10px" }}
        />
        <button onClick={sendMessage}>Send</button>
      </div>
    </div>
  );
};

export default Chat;
