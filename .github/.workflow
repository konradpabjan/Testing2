name: Python2
on: [push]
jobs:
  build:
    runs-on: [ubuntu-latest]
    strategy:
      matrix:
        python: [2.7, 3.8]
    steps:
      # Checkout code
      - name: 'Checkout'
        uses: actions/checkout@v1
      
      # Setup using a specific version of Python
      - name: 'Setup Python'
        uses: actions/setup-python@v1
        with:
          python-version: ${{ matrix.python }}
      
      # Install tools
      - name: 'Install tools'
        run: |
          python -c "import sys; print(sys.maxunicode)"
