FROM node:12-slim AS build
WORKDIR /usr/src/app
COPY package*.json ./
RUN npm install -g typescript
RUN npm install
COPY . .
RUN npm run build

FROM node:12-slim AS release 
WORKDIR /usr/src/app
COPY --from=build /usr/src/app/node_modules ./node_modules
COPY --from=build /usr/src/app/build ./build
CMD node ./build/src/config/server/index.js