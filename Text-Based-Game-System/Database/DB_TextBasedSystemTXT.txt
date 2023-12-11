CREATE TABLE Player(
PlayerID INT PRIMARY KEY, 
PlayerHealth INT, 
PlayerSanity INT, 
PlayerStrength INT, 
PlayerIntelligence INT,
PlayerDexterity INT,
Playerlevel INT,
Username VARCHAR(255) NOT NULL,
-- Add other player-related fields as needed
);

CREATE TABLE PlayerProgress(
ProgressID INT PRIMARY KEY, 
ProgressData TEXT,
PlayerID INT FOREIGN KEY REFERENCES Player(PlayerID)
);