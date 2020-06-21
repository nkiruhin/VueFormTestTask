<template>
  <div>
    <Navbar />
  </div>
</template>

<script lang='ts'>
import Vue from 'vue'
import Navbar from './components/Navbar.vue'
const App = Vue.extend({
  components: {
    Navbar
  }
})
export default App
</script>

<style>

</style>
