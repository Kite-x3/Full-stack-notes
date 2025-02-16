# Базовый образ Node.js
FROM node:18 AS build
WORKDIR /app

# Копируем файлы
COPY package.json ./
COPY package-lock.json ./
RUN npm install

COPY . .
RUN npm run build