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

INSERT INTO users(user_name, user_password) VALUES ('Pete Jones', 'Pete');
INSERT INTO users(user_name, user_password) VALUES ('Greg Beckur', 'Greg');
INSERT INTO users(user_name, user_password) VALUES ('Michael Knight', 'Michael');
INSERT INTO users(user_name, user_password) VALUES ('Emiyes', 'Emiyes');

INSERT INTO rehearsal_rooms(rehearsal_room_name) VALUES ('ROroom');
INSERT INTO rehearsal_rooms(rehearsal_room_name) VALUES ('Mumusfészek');
INSERT INTO rehearsal_rooms(rehearsal_room_name) VALUES ('Próbazóna');

INSERT INTO booking VALUES (1,1,'2020.06.03.');
INSERT INTO booking VALUES (2,2,'2020.06.04.');
INSERT INTO booking VALUES (3,1,'2020.06.03.');
INSERT INTO booking VALUES (2,3,'2020.06.03.');