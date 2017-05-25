import matplotlib.pyplot as plt
from flask import Flask, send_from_directory, request

app = Flask(__name__)

@app.route("/pie")
def pieChart():
    labels = [x for x in request.args.get("names").split(";") if x]
    sizes = [float(x) for x in request.args.get("values").split(";") if x]
    explode = tuple([0.03]*len(sizes))
    plt.pie(sizes, explode=explode, labels=labels,
            autopct='%1.1f%%', shadow=False, startangle=90)
    plt.axis('equal')
    plt.savefig("chart.png")
    plt.clf()
    return send_from_directory("","chart.png")

@app.route("/flow")
def flowChart():
    X = [float(x) for x in request.args.get("x").split(";") if x]
    Y = [float(x) for x in request.args.get("y").split(";") if x]
    plt.plot(X,Y)
    plt.savefig("flow.png")
    plt.clf()
    return send_from_directory("","flow.png")

app.debug = True
app.run()
