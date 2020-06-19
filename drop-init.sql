CREATE TABLE users(
	user_id SERIAL PRIMARY KEY,
	user_name TEXT NOT NULL,
	user_password TEXT NOT NULL
);

CREATE TABLE rehearsal_rooms(
	rehearsal_room_id SERIAL PRIMARY KEY,
	rehearsal_room_name TEXT NOT NULL,
	user_id INT REFERENCES users (user_id)
);

CREATE TABLE booking(
	user_id INT REFERENCES users (user_id),
	rehearsal_room_id INT REFERENCES rehearsal_rooms (rehearsal_room_id),
	booking_date TEXT NOT NULL
);