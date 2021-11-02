# proagilv1-fullstackangulardotnet
Primeira versão do curso Seja full stack .net core+ angular e EF 
Projeto webapi+ angular 10 + Entity Framework 
com automapper,angular + jwt .net core identity,Dto, Domain e Bootstap e ngx bootstrap e SqLite

O projeto é separo em 4 partes 
  1-FrontEnd Angular 10 + ngxbootstrap
  2-Domain
  3-Repository
  4-.net core 2.2 WebApi

comando utis pra instalar e rodar as dependencias

npm istall(instalar o nodejs)]

npm install -g @angular/cli@10.* instalando o angular 10

dotnet new webapi -n  ProAgil.WebAPI criando  projeto web api .net core

ng new ProAgil.APP criando o projeto angular

npm install bootstrap

instalando o bootstrap e o fronawesome icons

npm i --save bootstrap @fontawesome/fontawesome-free

npm i bootstrap-icons


 
ir pra pastar da api e rodar
cd ProAgil.WebAPI 

dotnet watch run

ir para pastar do angular e rodar a applicação

cd ProAgil-App

ng serve -o

 Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser ativando o comando ng no windonws

linkando dependencias do projetos .net domain e repository a api

dotnet new sln -n ProAgil

dotnet add ProAgil.Repository/ProAgil.Repository.csproj reference ProAgil.Domain/ProAgil.Domain.csproj

dotnet add ProAgil.WebAPI/ProAgil.WebAPI.csproj reference ProAgil.Domain/ProAgil.Domain.csproj 

dotnet add ProAgil.WebAPI/ProAgil.WebAPI.csproj reference ProAgil.Repository/ProAgil.Repository.csproj

dotnet sln ProAgil.sln add ProAgil.WebAPI/ProAgil.WebAPI.csproj ProAgil.Repository/ProAgil.Repository.csproj ProAgil.Domain/ProAgil.Domain.csproj  

npm install ngx-bootstrap --save instalando o ngx boostrap

npm install ngx-toastr --save -> instalando o toastr do ngxbootstrap

dotnet ef --startup-project ../ProAgil.WebAPI migrations add init criando o migrate

dotnet ef --startup-project ../ProAgil.WebAPI database update rodando o migration para criar a base


npm i @auth0/angular-jwt -> instalando do auth do angular

ng g g auth/auth  -> instalando dependencias do auth do angular globalmente

npm install --save ngx-mask ->instalando mascara de telofone

npm install ngx-currency --save ->instalando mascara de moeda
