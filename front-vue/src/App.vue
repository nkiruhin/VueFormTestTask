<template>
  <div>
    <Navbar />
    <Home />
  </div>
</template>

<script lang='ts'>
import Vue from 'vue'
import Home from './views/Home.vue'
import Navbar from './components/Navbar.vue'
const App = Vue.extend({
  components: {
    Navbar,
    Home
  }
})
export default App
</script>

<style>

</style>
