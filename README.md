# VueFormTestTask
A  project based on a test task
<!--
*** Thanks for checking out this README Template. If you have a suggestion that would
*** make this better please fork the repo and create a pull request or simple open
*** an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
-->





<!-- PROJECT SHIELDS -->
[![Build Status][build-shield]]()
[![Contributors][contributors-shield]]()
[![MIT License][license-shield]][license-url]



<!-- PROJECT LOGO -->
<br />


  <h3 align="center">README</h3>

  <p align="center">
    README !
    <br />
    <a href="https://github.com/nkiruhin/VueFormTestTask/blob/master/README.md"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <!--<a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>-->
    ·
    <a href="https://github.com/nkiruhin/VueFormTestTask/issues">Report Bug</a>
    ·
    <a href="https://github.com/nkiruhin/VueFormTestTask/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
  * [Start](#start)
* [Usage](#usage)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)



<!-- ABOUT THE PROJECT -->
## About The Project
![2020-06-22_09-50-20](https://user-images.githubusercontent.com/39044526/85252871-f4388080-b46d-11ea-9eca-3527c50967de.jpg)

The app contains a web form for creating entity.

Web form containing different field types e.g. single-line text, multiple-line text, drop-down, date, radio, and checkboxes.

Implemented client-side validation for form.

Implemented API for saving and searching the submissions of the form.

Created a input field for searching submissions of the form. 
The search data as well as corresponding API not depend on certain field types the original form consisted of. 
At the same time, all fields of the original form must be included in the search index. 
Modifications to the original form e.g. adding/removing fields, 
changing field types, should not affect API and the search page. 
If you add new fields to your form, submissions from both forms (prior and after modifications) 
must be searchable and new fields must be included in the search index automatically.

### Built With

* [ASP.Net Core](https://github.com/dotnet/core)
* [Vue.js](https://vuejs.org/)
* [CoreUI](https://coreui.io/vue/)



<!-- GETTING STARTED -->
## Getting Started

This article provides information on getting started this project.
<p>
First, download and install the .NET Core SDK on your computer.
<p>
You must install node.js from https://nodejs.org/en/download/

### Prerequisites

Prerequisites for this project you can find on links
.Net Core 3.1

for Windows:
https://docs.microsoft.com/en-us/dotnet/core/install/dependencies?pivots=os-windows&tabs=netcore31

for Linux:
https://docs.microsoft.com/en-us/dotnet/core/install/dependencies?pivots=os-linux&tabs=netcore31




### Installation

1. Clone the repo
```sh
git clone https://github.com/nkiruhin/VueFormTestTask.git
```
2. Change directory VueForm.FrontEnd
3. Install NPM packages
```sh
npm install
```

## Start

In VueForm.FrontEnd directory type
```sh
npm run serve
```
Open file project .sln in Microsoft Visual Studio.

Set running project VueForm.Web.

Start it without debugging (Ctrl+F5)

<!-- USAGE EXAMPLES -->
## Usage


_For examples, please refer to the [Documentation](https://github.com/nkiruhin/VueFormTestTask/wiki)_



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Nikolay Kirukhin  - nkiruhin@yandex.ru

Project Link: [https://github.com/nkiruhin/VueFormTestTask](https://github.com/nkiruhin/VueFormTestTask)









<!-- MARKDOWN LINKS & IMAGES -->
[build-shield]: https://img.shields.io/badge/build-passing-brightgreen.svg?style=flat-square
[contributors-shield]: https://img.shields.io/badge/contributors-1-orange.svg?style=flat-square
[license-shield]: https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square
[license-url]: https://choosealicense.com/licenses/mit
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: https://raw.githubusercontent.com/othneildrew/Best-README-Template/master/screenshot.png

