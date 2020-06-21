<template>
    <CInput placeholder='type string...'
            :value.sync='searchText'
            horizontal>
        <template #append>
            <CButton color='primary'
                     variant='outline'
                     @click='Go'>Go!</CButton>
        </template>
    </CInput>
</template>

<script lang='ts'>
import Vue from 'vue'
const Search = Vue.extend({
  data () {
    return {
      searchText: ''
    }
  },
  methods: {
    Go () {
      this.$emit('go', {
        searchText: this.searchText
      })
    }
  }
})
export default Search
</script>

<style></style>
