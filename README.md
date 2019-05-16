# Weather Dahboard

### About

This project is my design patterns study implementation. The idea here is merge [IBGE](https://servicodados.ibge.gov.br/api/docs/malhas?versao=2)'s and [CPTEC](http://servicos.cptec.inpe.br/XML/#req-busca-localidade)'s API to create a customizable API that can be consumed by any application. For now I've just have a contract to get the data, convert them to objects, a simple winforms and uwp application to test [LiveCharts](https://github.com/Live-Charts/Live-Charts) components.

### Solutin Structure

- API
  - WeatherDashboard.API
- Common
  - WeatherDashboard.Contracts
  - WeatherDashboard.DTO
- Tests
  - WeatherDashboard.Tests
- UI
  - WeatherDashboard.UWP
  - WeatherDashboard.WinForms

### Roadmap

- ~~Contract to merge data formats~~
- ~~Object serialization~~
- ~~HTTP/HTTPS request URI builder~~
- Weather Dashboard REST API
- Weather Dashboard WinForms
- Weather Dahbooard UWP
- Weather Dashboard React
