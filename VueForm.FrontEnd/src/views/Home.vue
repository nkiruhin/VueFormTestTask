<template>
  <div>
    <action-panel />
  </div>
</template>

<script lang='ts'>
import Vue from 'vue'
import ActionPanel from '../components/ActionPanel.vue'

const Home = Vue.extend({
  name: 'home',
  components: {
    ActionPanel
  }
})
export default Home
</script>

<!-- Add 'scoped' attribute to limit CSS to this component only -->
<style>

</style>
